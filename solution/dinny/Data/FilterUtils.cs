//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Reflection;

//using DevExpress.Data.Filtering;
//using DevExpress.Data.Linq;
//using NHibernate;
//using NHibernate.Criterion;

//namespace expertAccounts.Core.Data
//{
//    public static class FilterUtils
//    {
//        /// <summary>
//        /// Получить lambda-выражение из строки фильтра дев-грида
//        /// на вход подается сама строка (например: [file] like 'xxx')
//        /// на выход должно быть x=>x.filename like 'xxx' или для NH x=>x.filename.isLike('xxx')
//        /// </summary>
//        /// <param name="lpFilter"></param>
//        /// <returns></returns>
//        public static Expression<Func<T, bool>> getLambdaByFilter <T>(CriteriaOperator lpFilter)
//        {
//            Expression<Func<T, bool>> expr2 = null;
//            if (!ReferenceEquals(lpFilter, null) && lpFilter.GetType() == typeof(BinaryOperator)) // убрать по мере переподключения фильтров
//            {
//                // операции по конвертации выражения фильтра из dev-грида в lambda-выражение
//                CriteriaToExpressionConverter converter = new CriteriaToExpressionConverter();
//                BinaryOperator lcBinOp = lpFilter as BinaryOperator;
//                ParameterExpression param = System.Linq.Expressions.Expression.Parameter(typeof(T), "x");
//                ConstantExpression value = System.Linq.Expressions.Expression.Constant(lcBinOp.RightOperand, lcBinOp.RightOperand.GetType());
//                System.Linq.Expressions.Expression exprFilter = converter.Convert(param, lpFilter); // <--- предварительный вид выражения
//                if (lcBinOp.OperatorType != BinaryOperatorType.Like) // для LIKE отдельная история. см. ниже
//                {
//                    // конверт из типа Expression в тип Expression<Func<T, bool>>
//                    expr2 = System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(exprFilter, new ParameterExpression[] { param });
//                }
//                else
//                {
//                    // заменить * на %
//                    lcBinOp.RightOperand = lcBinOp.RightOperand.ToString()
//                        .Replace("*", "%").Substring(1, lcBinOp.RightOperand.ToString().Length - 2); // пляски с цеплянием с 1 по предпоследнюю букву обусловлены добавлением 
//                                                                                                     // знака "'" оператором ToString()

//                    var x = System.Linq.Expressions.Expression.Parameter(typeof(T), "x");
//                    var prop = System.Linq.Expressions.Expression.Property(x, (lcBinOp.LeftOperand as OperandProperty).PropertyName);
//                    // привязка к SqlClient методу LIKE
//                    // var body = System.Linq.Expressions.Expression.Call(typeof(SqlMethods), "Like", null, prop,
//                    //                System.Linq.Expressions.Expression.Constant(value.Value.ToString()));
//                    // поскольку используется NH в параметры ICriteria в качестве LIKE подается 
//                    // метод-расширение IsLike (странно конечно со стороны NH). Поэтому Sql LIKE не подходит - находим
//                    // объявление в сборке расширения и пересоздаем lambda-выражение
                    
//                    var body = System.Linq.Expressions.Expression.Call(typeof(NHibernate.Criterion.RestrictionExtensions), "IsLike", null, prop,
//                        System.Linq.Expressions.Expression.Constant(value.Value.ToString().Substring(1, lcBinOp.RightOperand.ToString().Length - 2))); // см. выше
//                    expr2 = System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(body, x);
//                }
//            }
//            return expr2;
//        }

//        public static Expression<Func<T, bool>> getGroupLambdaByFilter<T>(CriteriaOperator lpFilter)
//        {
//            Expression<Func<T, bool>> expr2 = null;
//            if (!ReferenceEquals(lpFilter, null))
//            {
//                if (lpFilter.GetType() == typeof(BinaryOperator))
//                {
//                    return getLambdaByFilter<T>(lpFilter);
//                }
//                else if (lpFilter.GetType() == typeof(GroupOperator))
//                {
//                    int i = 0;
//                    foreach (BinaryOperator operand in ((GroupOperator)lpFilter).Operands)
//                    {
//                        Expression<Func<T, bool>> lcExpr = getLambdaByFilter<T>(operand);

//                        if (i == 0) // первая инициализация
//                            expr2 = lcExpr;
//                        else
//                        {
//                            var body = (((GroupOperator)lpFilter).OperatorType == GroupOperatorType.And) ?
//                                    System.Linq.Expressions.Expression.And(lcExpr.Body, expr2.Body) : System.Linq.Expressions.Expression.Or(lcExpr.Body, expr2.Body);
//                            expr2 = System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(body, lcExpr.Parameters[0]);
//                        }
//                        i++;
//                    }
//                }
//            }                
//            return expr2;
//        }

//        /// <summary>
//        /// Получение одного критерия для поиска данных, исходя из предоставленного фильтра DevExpress
//        /// </summary>
//        /// <param name="lpFilter"></param>
//        /// <returns></returns>        
//        public static ICriterion FilterToCriterea<T>(ref ICriteria lpCriteria, CriteriaOperator lpFilter)
//        {
//            ICriterion lcCriteria = null;

//            if (!ReferenceEquals(lpFilter, null))
//            {
//                BinaryOperator lcBinOp = null;

//                if (lpFilter.GetType() == typeof(BinaryOperator))
//                    lcBinOp = lpFilter as BinaryOperator;
//                else if (lpFilter.GetType() == typeof(UnaryOperator))
//                {
//                    lcBinOp = (lpFilter as UnaryOperator).Operand as BinaryOperator;
//                }

//                // название поля с алиасом
//                // немного манипуляций для критериев к присоединенным таблицам
//                // суть сводится к добавлению алиаса для этих таблиц
//                string pureleftOp = FieldName(lcBinOp.LeftOperand.ToString().Replace("[", "").Replace("]", ""));
//                string lcSubAlias = lcBinOp.LeftOperand.ToString()
//                    .Replace("." + pureleftOp, "").Replace("[", "").Replace("]", "")
//                    .Replace(".", "_");
//                string lcTypeName = FieldName(typeof(T).ToString());
//                string lcAliasName = lcTypeName + "_" + lcSubAlias;                
//                string leftOp = "";
//                if (lcBinOp.LeftOperand.ToString().IndexOf(".") != -1)
//                {
//                    lpCriteria.CreateAlias(lcSubAlias, lcAliasName);
//                    leftOp = lcAliasName + "." + pureleftOp;
//                }
//                else
//                    leftOp = pureleftOp;
                
//                string rightVal = (lcBinOp.RightOperand as OperandValue).Value.ToString()
//                                                      .Replace("*", "%");
//                object rightOp = Convert.ChangeType(rightVal, MemberSystemType<T>(lcBinOp.LeftOperand.ToString())); // для комплексного типа нужна процедура 
//                                                                                               // определения типов его членов
//                switch(lcBinOp.OperatorType)
//                {
//                    case BinaryOperatorType.Equal:
//                        lcCriteria = NHibernate.Criterion.Restrictions.Eq(leftOp, rightOp);
//                        break;
//                    case BinaryOperatorType.NotEqual:
//                        lcCriteria = !NHibernate.Criterion.Expression.Eq(leftOp, rightOp);
//                        break;
//                    case BinaryOperatorType.Like:
//                        if (lpFilter.GetType() != typeof(UnaryOperator))
//                            lcCriteria = NHibernate.Criterion.Expression.Like(leftOp, rightOp);
//                        else
//                            lcCriteria = !NHibernate.Criterion.Expression.Like(leftOp, rightOp);
//                        break;                    
//                    case BinaryOperatorType.Less:
//                        lcCriteria = NHibernate.Criterion.Expression.Lt(leftOp, rightOp);
//                        break;
//                    case BinaryOperatorType.LessOrEqual:
//                        lcCriteria = NHibernate.Criterion.Expression.Le(leftOp, rightOp);
//                        break;
//                    case BinaryOperatorType.Greater:
//                        lcCriteria = NHibernate.Criterion.Expression.Gt(leftOp, rightOp);
//                        break;
//                    case BinaryOperatorType.GreaterOrEqual:
//                        lcCriteria = NHibernate.Criterion.Expression.Ge(leftOp, rightOp);
//                        break;

//                    default:
//                        break;
//                }
//            }
//            return lcCriteria;
//        }

//        public static Type MemberSystemType<T>(string lpMember)
//        {
//            Type retType = typeof(string); // тип по умолчанию
//            Type lcType = typeof(T);

//            string pureleftOp = FieldName(lpMember.Replace("[", "").Replace("]", ""));
//            if (lpMember.IndexOf(".") == -1)
//                retType = lcType.GetProperty(pureleftOp).PropertyType;
//            else
//            {
//                string pureSubType = FieldName(lpMember.Replace("[", "").Replace("]", "")
//                        .Replace("." + pureleftOp, ""));                
//                foreach (MemberInfo member in lcType.GetMembers())
//                {
//                    if (member.MemberType == MemberTypes.Property)
//                    {
//                        if (member.Name == pureSubType)
//                        {
//                            pureSubType = member.ToString().Replace(" " + pureSubType, "");
//                            break;
//                        }
//                    }
//                }
//                Type lcSubType = Type.GetType(pureSubType);
//                retType = lcSubType.GetProperty(pureleftOp).PropertyType;
//            }
//            return retType;
//        }

//        private static string FieldName(string lpParam)
//        {
//            return lpParam.Substring(lpParam.LastIndexOf(".") + 1, lpParam.Length - lpParam.LastIndexOf(".") - 1);
//        }

//        private static string AliasName(string lpParam)
//        {
//            return lpParam.Replace(".", "_");
//        }

//        /// <summary>
//        /// Добавление списка критериев для поиска данных в экземпляр сессии, исходя из предоставленного фильтра DevExpress
//        /// </summary>
//        /// <param name="lpFilter"></param>
//        /// <returns></returns>
//        public static void FilterToCritereas<T>(ref ICriteria lpCriteria, CriteriaOperator lpFilter)
//        {            
//            if (!ReferenceEquals(lpFilter, null))
//            {
//                if (lpFilter.GetType() == typeof(BinaryOperator))
//                {
//                    lpCriteria.Add(FilterToCriterea<T>(ref lpCriteria, lpFilter));
//                }
//                else if (lpFilter.GetType() == typeof(UnaryOperator))
//                {
//                    lpCriteria.Add(FilterToCriterea<T>(ref lpCriteria, lpFilter));
//                }
//                else if (lpFilter.GetType() == typeof(GroupOperator))
//                {
//                    if ((lpFilter as GroupOperator).OperatorType == GroupOperatorType.And)
//                        foreach (BinaryOperator oper in ((GroupOperator)lpFilter).Operands)
//                        {
//                            lpCriteria.Add(FilterToCriterea<T>(ref lpCriteria, oper));
//                        }
//                    else
//                    {
//                        List<ICriterion> lcList = new List<ICriterion>();
//                        foreach (BinaryOperator oper in ((GroupOperator)lpFilter).Operands)
//                        {
//                            lcList.Add(FilterToCriterea<T>(ref lpCriteria, oper));
//                        }
//                        ICriterion lcCriteria = lcList[0];
//                        for (int i = 1; i < lcList.Count; i++)
//                            lcCriteria = Restrictions.Or(lcCriteria, lcList[i]);
//                        lpCriteria.Add(lcCriteria);
//                    }
//                }
//            }            
//        }    
//    }
//}

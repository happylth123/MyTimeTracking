using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTimeTracking.Infrastructures
{
    public static class QueryExtension
    {
        public static IQueryable<TResponse> OrderBy<TResponse>(this IQueryable<TResponse> data, Expression<Func<TResponse, object>> sortExpression, bool ascending) where TResponse : class
        {
            if (sortExpression == null)
            {
                return data;
            }

            IQueryable<TResponse> result;

            if (sortExpression.Body.NodeType == ExpressionType.Convert)
            {
                string command = ascending ? "OrderBy" : "OrderByDescending";
                var propertyAccess = (sortExpression.Body as UnaryExpression).Operand;
                var orderByExpression = Expression.Lambda(propertyAccess, sortExpression.Parameters);
                var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { typeof(TResponse), propertyAccess.Type }, data.Expression, Expression.Quote(orderByExpression));
                result = data.Provider.CreateQuery<TResponse>(resultExpression);
            }
            else
            {
                if (ascending)
                {
                    result = data.OrderBy(sortExpression);
                }
                else
                {
                    result = data.OrderByDescending(sortExpression);
                }
            }

            return result;
        }
    }
}

namespace SharpCondition
{
	public class Condition
	{
		public delegate void MethodToInvokeArgs(params object[] args);
		public delegate void ErrorInvokeArgs(params object[] args);

		public static void If(bool expression, bool requiredValue, MethodToInvokeArgs method, ErrorInvokeArgs error = null, object[] methodArgs = null, object[] errorArgs = null)
		{
			if (expression == requiredValue)
			{
				method.Invoke(methodArgs);
			}
			else if (expression != requiredValue)
			{
				if (error != null) error.Invoke(errorArgs);
				else return;
			}
		}
		public static void If<T>(T expression, T requiredValue, MethodToInvokeArgs method, ErrorInvokeArgs error = null, object[] methodArgs = null, object[] errorArgs = null)
		{
			object expressionObj = expression;
			object requiredValueObj = requiredValue;

			if (expressionObj == requiredValueObj)
			{
				method.Invoke(methodArgs);
			}
			else if(expressionObj != requiredValueObj)
			{
				if (error != null) error.Invoke(errorArgs);
				else return;
			}
		}
	}
}

using Microsoft.Extensions.DependencyInjection;
using No1.Commons.Exceptions;

namespace No1.asp.NET.Commons.Utility;

public static class ServiceUtility
{
	public static T GetNeededService<T>(this IServiceProvider serviceProvider)
	where T : notnull {
		return NullExpressionException.Exec(() => serviceProvider.GetRequiredService<T>());
	}
}
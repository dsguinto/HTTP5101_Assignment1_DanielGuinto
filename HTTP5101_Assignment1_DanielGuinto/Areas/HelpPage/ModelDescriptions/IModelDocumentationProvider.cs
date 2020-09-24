using System;
using System.Reflection;

namespace HTTP5101_Assignment1_DanielGuinto.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
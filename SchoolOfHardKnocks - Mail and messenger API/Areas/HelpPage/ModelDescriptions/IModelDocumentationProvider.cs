using System;
using System.Reflection;

namespace SchoolOfHardKnocks___Mail_and_messenger_API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
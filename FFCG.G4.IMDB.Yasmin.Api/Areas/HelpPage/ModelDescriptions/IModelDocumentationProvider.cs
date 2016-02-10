using System;
using System.Reflection;

namespace FFCG.G4.IMDB.Yasmin.Api.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
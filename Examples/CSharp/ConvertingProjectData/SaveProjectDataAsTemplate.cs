using Aspose.Tasks.Saving;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    public class SaveProjectDataAsTemplate
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:SaveProjectDataAsTemplate   
                const string ProjectName = "Project2.mpp";
                Project project = new Project(dataDir + ProjectName);
                ProjectFileInfo projectFileInfo = Project.GetProjectFileInfo(dataDir + ProjectName);

                if (FileFormat.MPP14 == projectFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Project file format is ok");
                }

                SaveTemplateOptions options = new SaveTemplateOptions();
                options.RemoveActualValues = true;
                options.RemoveBaselineValues = true;

                const string TemplateName = "SaveProjectDataAsTemplate_out.mpt";
                project.SaveAsTemplate(dataDir + TemplateName);

                ProjectFileInfo templateFileInfo = Project.GetProjectFileInfo(dataDir + TemplateName);
                if (FileFormat.MPT14 == templateFileInfo.ProjectFileFormat)
                {
                    Console.WriteLine("Template FileFormat is ok");
                }
                //ExEnd:SaveProjectDataAsTemplate
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
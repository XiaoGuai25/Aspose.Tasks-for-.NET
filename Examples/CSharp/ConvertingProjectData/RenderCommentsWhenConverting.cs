﻿namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    public class RenderCommentsWhenConverting
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:RenderCommentsWhenConverting
            Project project = new Project(dataDir + "Input.mpp");
            project.DefaultView.PageInfo.PageViewSettings.PrintNotes = true;
            project.Save(dataDir + "ProjectWithComments.pdf", Saving.SaveFileFormat.PDF);
            //ExEnd:RenderCommentsWhenConverting
        }
    }
}

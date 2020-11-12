using Altseed2;

namespace GUIBuilder.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.EnabledCoreModules = CoreModules.Default | CoreModules.Tool;
            Engine.Initialize("GUI Builder Test", 640, 480, config);

            GUIManagerNode node = new GUIManagerNode();
            Engine.AddNode(node);
            
            node.AddGUIItem(Altseed2.GUIBuilder.Instance.CreateFromXMLFile("WindowTest.xml"));

            while(Engine.DoEvents())
            {
                Engine.Update();
                if(node.GetItemsWithAttr<GUIWindow>("").GetItemsWithAttr<GUIButton>("fugafuga").IsClicked)
                {
                    System.Console.WriteLine("FUGA");
                }
            }

            Engine.Terminate();
        }
    }
}

using System;
using System.Xml;

namespace Altseed2
{
    public abstract class GUIItem
    {
        public static GUIItem CreateFromXML(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            
            return CreateFromXML((XmlElement)xml.ChildNodes[1]);
        }

        private static GUIItem CreateFromXML(XmlElement element)
        {
            switch(element.Name)
            {
                case "Window":
                {
                    GUIWindow item = new GUIWindow();
                    item.Name = element.GetAttribute("Name");
                    item.Attr = element.GetAttribute("Attr");

                    foreach(XmlNode child in element.ChildNodes)
                        item.AddGUIItem(CreateFromXML((XmlElement)child));

                    return item;
                }
                case "Text":
                {
                    GUIText item = new GUIText();
                    item.Name = element.GetAttribute("Text");
                    return item;
                }
                default:
                    throw new NotImplementedException();
            }
        }

        protected string Label => Name + (Attr == "" ? "" : ("###" + Attr));
        public string Name { get; set; }
        public string Attr { get; set; }

        public bool IsUpdated { get; set; }

        public GUIItem()
        {
            Name = "";
            Attr = "";
            IsUpdated = true;
        }

        internal void Update()
        {
            if(IsUpdated) OnUpdate();
        }

        protected abstract void OnUpdate();
    }
}
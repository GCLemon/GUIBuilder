using System;
using System.Xml;

namespace Altseed2
{
    public class GUIBuilder
    {
        public static GUIBuilder Instance { get; } = new GUIBuilder();

        private GUIBuilder() { }

        public GUIItem CreateFromXMLFile(string xmlPath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);

            return CreateFromXML((XmlElement)document.ChildNodes[1]);
        }

        private GUIItem CreateFromXML(XmlElement element)
        {
            switch(element.Name)
            {
                case "Window":
                    return CreateWindow(element);

                case "Text":
                    return CreateText(element);

                case "Button":
                    return CreateButton(element);

                case "ImageButton":
                    return CreateImageButton(element);

                case "ArrowButton":
                    return CreateArrowButton(element);

                case "SmallButton":
                    return CreateSmallButton(element);

                default:
                    throw new NotSupportedException();
            }
        }

        private GUIWindow CreateWindow(XmlElement element)
        {
            GUIWindow item = new GUIWindow();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            foreach(XmlNode child in element.ChildNodes)
            {
                if(child.Name == "SameLine")
                    for(int i = 0; i < child.ChildNodes.Count; ++i)
                    {
                        GUIItem sameLineItem = CreateFromXML((XmlElement)child.ChildNodes[i]);
                        sameLineItem.IsSameLine = i != 0;
                        item.AddGUIItem(sameLineItem);
                    }
                
                else item.AddGUIItem(CreateFromXML((XmlElement)child));
            }

            return item;
        }

        private GUIText CreateText(XmlElement element)
        {
            GUIText item = new GUIText();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            return item;
        }

        private GUIButton CreateButton(XmlElement element)
        {
            GUIButton item = new GUIButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            return item;
        }

        private GUIImageButton CreateImageButton(XmlElement element)
        {
            GUIImageButton item = new GUIImageButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            string path = element.GetAttribute("Path");
            if(path != string.Empty) item.Image = Texture2D.Load(path);
            
            return item;
        }

        private GUIArrowButton CreateArrowButton(XmlElement element)
        {
            GUIArrowButton item = new GUIArrowButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            item.Driection = element.GetAttribute("Direction") switch 
            {
                "Left" => ToolDir.Left,
                "Right" => ToolDir.Right,
                "Up" => ToolDir.Up,
                "Down" => ToolDir.Down,
                _ => ToolDir.None,
            };

            return item;
        }

        private GUISmallButton CreateSmallButton(XmlElement element)
        {
            GUISmallButton item = new GUISmallButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            return item;
        }
    }
}
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
                    
                case "Group":
                    return CreateGroup(element);

                case "MenuBar":
                    return CreateMenuBar(element);

                case "MainMenuBar":
                    return CreateMainMenuBar(element);

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

                case "InputText":
                    return CreateInputText(element);

                case "InputTextMultiLine":
                    return CreateInputTextMultiline(element);

                case "InputTextWithHint":
                    return CreateInputTextWithHint(element);

                case "InputInt":
                    return CreateInputInt(element);

                case "InputInt2":
                    return CreateInputInt2(element);

                case "InputInt3":
                    return CreateInputInt3(element);

                case "InputInt4":
                    return CreateInputInt4(element);

                case "InputFloat":
                    return CreateInputFloat(element);

                case "InputFloat2":
                    return CreateInputFloat2(element);

                case "InputFloat3":
                    return CreateInputFloat3(element);

                case "InputFloat4":
                    return CreateInputFloat4(element);

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

        private GUIGroup CreateGroup(XmlElement element)
        {
            GUIGroup item = new GUIGroup();
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

        private GUIMenuBar CreateMenuBar(XmlElement element)
        {
            GUIMenuBar item = new GUIMenuBar();
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

        private GUIMainMenuBar CreateMainMenuBar(XmlElement element)
        {
            GUIMainMenuBar item = new GUIMainMenuBar();
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
            item.Image = Texture2D.Load(element.GetAttribute("Path"));

            return item;
        }

        private GUIArrowButton CreateArrowButton(XmlElement element)
        {
            GUIArrowButton item = new GUIArrowButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            string dirStr = element.GetAttribute("Direction");
            item.Driection = Enum.TryParse<ToolDir>(dirStr, false, out ToolDir dir) ? dir : ToolDir.None;

            return item;
        }

        private GUISmallButton CreateSmallButton(XmlElement element)
        {
            GUISmallButton item = new GUISmallButton();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");

            return item;
        }

        private GUIInputText CreateInputText(XmlElement element)
        {
            GUIInputText item = new GUIInputText();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputTextMultiline CreateInputTextMultiline(XmlElement element)
        {
            GUIInputTextMultiline item = new GUIInputTextMultiline();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputTextWithHint CreateInputTextWithHint(XmlElement element)
        {
            GUIInputTextWithHint item = new GUIInputTextWithHint();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputInt CreateInputInt(XmlElement element)
        {
            GUIInputInt item = new GUIInputInt();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputInt2 CreateInputInt2(XmlElement element)
        {
            GUIInputInt2 item = new GUIInputInt2();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputInt3 CreateInputInt3(XmlElement element)
        {
            GUIInputInt3 item = new GUIInputInt3();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputInt4 CreateInputInt4(XmlElement element)
        {
            GUIInputInt4 item = new GUIInputInt4();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputFloat CreateInputFloat(XmlElement element)
        {
            GUIInputFloat item = new GUIInputFloat();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputFloat2 CreateInputFloat2(XmlElement element)
        {
            GUIInputFloat2 item = new GUIInputFloat2();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputFloat3 CreateInputFloat3(XmlElement element)
        {
            GUIInputFloat3 item = new GUIInputFloat3();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }

        private GUIInputFloat4 CreateInputFloat4(XmlElement element)
        {
            GUIInputFloat4 item = new GUIInputFloat4();
            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            
            return item;
        }
    }
}
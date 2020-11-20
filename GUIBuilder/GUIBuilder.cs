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
            GUIItem item = element.Name switch
            {
                "Window" => CreateWindow(element),
                "Group" => CreateGroup(element),
                "MenuBar" => CreateMenuBar(element),
                "MainMenuBar" => CreateMainMenuBar(element),

                "Text" => CreateText(element),

                "Button" => CreateButton(element),
                "ImageButton" => CreateImageButton(element),
                "ArrowButton" => CreateArrowButton(element),

                "InputText" => CreateInputText(element),
                "InputTextMultiLine" => CreateInputTextMultiLine(element),
                "InputInt" => CreateInputInt(element),
                "InputFloat" => CreateInputFloat(element),

                "Separator" => CreateSeparator(element),

                _ => throw new NotSupportedException()
            };

            item.Name = element.GetAttribute("Name");
            item.Attr = element.GetAttribute("Attr");
            if(Boolean.TryParse(element.GetAttribute("IsUpdated"), out bool isUpdated)) item.IsUpdated = isUpdated;
            return item;
        }

        private GUIWindow CreateWindow(XmlElement element)
        {
            GUIWindow item = new GUIWindow();

            string[] value = null;

            value = element.GetAttribute("Size").Split(",");
            if(value.Length == 2)
            {
                if(Single.TryParse(value[0], out float width))
                    if(Single.TryParse(value[1], out float height))
                        item.Size = new Vector2F(width, height);
            }

            value = element.GetAttribute("Pos").Split(",");
            if(value.Length == 2)
            {
                if(Single.TryParse(value[0], out float xPos))
                    if(Single.TryParse(value[1], out float yPos))
                        item.Position = new Vector2F(xPos, yPos);
            }

            foreach(string flag in element.GetAttribute("Flags").Split("|"))
                if(Enum.TryParse<ToolWindowFlags>(flag, false, out ToolWindowFlags flags))
                    item.Flags |= flags;
            
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
            item.Mode = Enum.TryParse<GUITextMode>(element.GetAttribute("Mode"), false, out GUITextMode dir) ? dir : GUITextMode.Normal;
            if(item.Mode == GUITextMode.Colored)
            {
                string[] value = element.GetAttribute("Color").Split(",");
                if(value.Length == 4)
                {
                    if(Int32.TryParse(value[0], out int r))
                        if(Int32.TryParse(value[1], out int g))
                            if(Int32.TryParse(value[2], out int b))
                                if(Int32.TryParse(value[3], out int a))
                                    item.Color = new Color(r, g, b, a);
                }
            }
            return item;
        }

        private GUIButton CreateButton(XmlElement element)
        {
            GUIButton item = new GUIButton();
            return item;
        }

        private GUIImageButton CreateImageButton(XmlElement element)
        {
            GUIImageButton item = new GUIImageButton();
            item.Image = Texture2D.Load(element.GetAttribute("Path"));

            string[] value = element.GetAttribute("Size").Split(",");
            if(value.Length == 2)
            {
                if(Single.TryParse(value[0], out float width))
                    if(Single.TryParse(value[1], out float height))
                        item.ImageSize = new Vector2F(width, height);
            }

            return item;
        }

        private GUIArrowButton CreateArrowButton(XmlElement element)
        {
            GUIArrowButton item = new GUIArrowButton();
            string dirStr = element.GetAttribute("Direction");
            item.Driection = Enum.TryParse<ToolDir>(dirStr, false, out ToolDir dir) ? dir : ToolDir.None;

            return item;
        }

        private GUIInputText CreateInputText(XmlElement element)
        {
            GUIInputText item = new GUIInputText();
            item.Hint = element.GetAttribute("Hint");
            return item;
        }

        private GUIInputTextMultiLine CreateInputTextMultiLine(XmlElement element)
        {
            GUIInputTextMultiLine item = new GUIInputTextMultiLine();
            return item;
        }

        private GUIInputInt CreateInputInt(XmlElement element)
        {
            GUIInputInt item = new GUIInputInt();
            if(Int32.TryParse(element.GetAttribute("ValueNum"), out int valueNum)) item.ValueNum = valueNum;
            return item;
        }

        private GUIInputFloat CreateInputFloat(XmlElement element)
        {
            GUIInputFloat item = new GUIInputFloat();
            if(Int32.TryParse(element.GetAttribute("ValueNum"), out int valueNum)) item.ValueNum = valueNum;
            return item;
        }

        private GUISeparator CreateSeparator(XmlElement element)
        {
            return new GUISeparator();
        }
    }
}
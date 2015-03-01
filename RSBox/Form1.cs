using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mshtml;

namespace RSBox
{
    public partial class Form1 : Form
    {
        // Constructor(s)
        public Form1()
        {
            //
            InitializeComponent();

            // Go to OldschoolRunescape
            _browser.Url = new Uri("http://oldschool84.runescape.com/j1");
        }

        //
        private List<HtmlElement> GetElementsByAttribute(HtmlDocument doc, string attribute, string value)
        {
            HtmlElementCollection collection = doc.All;
            List<HtmlElement> list = new List<HtmlElement>();

            for (int i = 0; i < collection.Count; i++)
                if (collection[i].GetAttribute(attribute) == value)
                    list.Add(collection[i]);

            return list;
        }
        private void RemoveElement(HtmlElement element)
        {
            IHTMLElement tmpElement = (IHTMLElement)element.DomElement;
            IHTMLDOMNode tmpNode = (IHTMLDOMNode)tmpElement;
            tmpNode.parentNode.removeChild(tmpNode);
        }

        // Events
        private void _bRemoveHTML_Click(object sender, EventArgs e)
        {
            List<HtmlElement> content;

            // Remove Menu
            content = GetElementsByAttribute(_browser.Document, "className", "menu");
            if (content.Count >= 1)
                RemoveElement(content[0]);

            // Remove Ad (Need to find out how to get it)
            //content = GetElementsByAttribute(_myBroswer.Document, "id", "AddOrSomeThing");
            //if (content.Count >= 1)
            //    RemoveElement(content[0]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SportsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private XmlNode GetXmlNode(string tagName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("dataBase.xml");

            return doc.GetElementsByTagName(tagName)[0];
        }


        private List<XmlNode> GetRelationshipNodes(string type)
        {
            var facts = GetXmlNode("facts");
            var relationships = facts.ChildNodes.Item(0).ChildNodes;

            List<XmlNode> nodeList = new List<XmlNode>();
            foreach (XmlNode node in relationships)
                if (node.Name == type)
                    nodeList.Add(node);

            return nodeList;
        }


        private List<string> GetParentActions(string childName, string actionType)
        {
            var rules = GetXmlNode("rules");
            var parentAuthorityRules = rules.ChildNodes.Item(0).ChildNodes;

            List<string> actions = new List<string>();
            for(int i = 0; i < parentAuthorityRules.Count; i += 2)
            {
                if(parentAuthorityRules.Item(i).ChildNodes.Item(0).InnerText == childName
                    && parentAuthorityRules.Item(i).ChildNodes.Item(2).InnerText == actionType)
                {
                    actions.Add(parentAuthorityRules.Item(i + 1).ChildNodes.Item(0).InnerText + "  " +
                        parentAuthorityRules.Item(i + 1).ChildNodes.Item(1).InnerText + "  " +
                        parentAuthorityRules.Item(i + 1).ChildNodes.Item(2).InnerText + ".");
                }
            }

            return actions;
        }


        private List<Parent> getParentsFromXml()
        {
            List<Parent> parents = new List<Parent>();

            var parentsNodes = GetRelationshipNodes("parent");
            foreach (var node in parentsNodes)
            {
                string parentName = "";
                List<string> children = new List<string>();

                var attributes = node.ChildNodes;
                for (int i = 0; i < attributes.Count; i++)
                {
                    var attribute = attributes.Item(i);
                    if (attribute.Name == "name")
                        parentName = attributes.Item(i).InnerText;
                    if (attribute.Name == "child")
                        children.Add(attribute.FirstChild.InnerText);

                }
                parents.Add(new Parent(parentName, children));
            }

            return parents;
        }

        private List<string> getBrothersFromXml()
        {
            List<string> brothers = new List<string>();

            var brothersNodes = GetRelationshipNodes("brothers");
            foreach (var node in brothersNodes)
            {
                var attributes = node.ChildNodes;
                for (int i = 0; i < attributes.Count; i++)
                {
                    var attribute = attributes.Item(i);
                    if (attribute.Name == "name")
                        brothers.Add(attributes.Item(i).InnerText);

                }
            }

            return brothers;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void showBrothers_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            var facts = GetXmlNode("facts");
            var relationships = facts.ChildNodes.Item(0).ChildNodes;
            
            foreach (XmlNode node in relationships)
            {
                if (node.Name == "brothers")
                {
                    var brothers = node.ChildNodes;

                    List<string> brotherNames = new List<string>();
                    for (int i = 0; i < brothers.Count; i++)
                        brotherNames.Add(brothers.Item(i).InnerText);

                    string result = "";
                    foreach(var name in brotherNames){
                        if(name != brotherNames.Last())
                            result += name + ", ";
                        else
                            result += name;
                    }

                    searchResult.Items.Add(result);
                }
            }
        }

        private void showCouples_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            List<Parent> parents = getParentsFromXml();

            while (parents.Count > 0)
            {
                var children = parents[0].children;
                var partner = parents.Where(p => p.children.All(children.Contains) && p.name != parents[0].name).FirstOrDefault();

                searchResult.Items.Add(parents[0].name + " + " + partner.name);

                parents.Remove(parents[0]);
                parents.Remove(partner);
            }
        }

        private void showParentsWithSiblings_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            var parents = getParentsFromXml();
            var brothers = getBrothersFromXml();

            var parentsWithSiblings = parents.Where(p => brothers.Any(b => b == p.name))
                .Select(p => new Person
                {
                    name = p.name,
                    children = p.children.Count()
                })
                .ToList();

            foreach(var parent in parentsWithSiblings)
            {
                string kidsComponent = " has " + parent.children + " kid";
                if(parent.children > 1)
                    kidsComponent += "s";
                searchResult.Items.Add(parent.name + kidsComponent);
            }
        }


        private void showChildren_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            var parents = getParentsFromXml();

            HashSet<string> childrenNames = new HashSet<string>();
            foreach (var parent in parents)
                foreach (var child in parent.children)
                    childrenNames.Add(child);

            foreach (var name in childrenNames)
                searchResult.Items.Add(name);
        }

        private void showParents_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            var parents = getParentsFromXml();
            
            foreach (var parent in parents)
                searchResult.Items.Add(parent.name);

        }


        private void searchInput_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Write the name of a child, select his behaviour and press \"Result\"  \nTo see a list of children, click on \"Show Children\".", searchInput);
            toolTip1.Show("Write the name of a child, select his behaviour and press \"Result\"  \nTo see a list of children, click on \"Show Children\".", label1);
            toolTip1.Show("Write the name of a child, select his behaviour and press \"Result\"  \nTo see a list of children, click on \"Show Children\".", radioauthorityButton);
            toolTip1.Show("Write the name of a child, select his behaviour and press \"Result\"  \nTo see a list of children, click on \"Show Children\".", radioshowChildren);
            toolTip1.Show("Write the name of a child, select his behaviour and press \"Result\"  \nTo see a list of children, click on \"Show Children\".", authorityResult);

        }
        private void searchInput_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(searchInput);
            toolTip1.Hide(label1);
            toolTip1.Hide(radioauthorityButton);
            toolTip1.Hide(radioshowChildren);
            toolTip1.Hide(authorityResult);
        }

        private void authorityButton_Click(object sender, EventArgs e)
        {
            string childName = searchInput.Text;
            if (childName != null && childName.Length >= 3)
            {
                authorityResult.Clear();

                var parents = getParentsFromXml().Where(p => p.children.Contains(childName)).ToList();
                if (parents.Count == 0) {
                    authorityResult.Items.Add(childName + " is responsible for his/her own actions,");
                    authorityResult.Items.Add("or he/she is not in the database.");
                }
                else if (parents.Count == 2)
                {
                    authorityResult.Items.Add(parents[0].name + "  and  " + parents[1].name + "  are responsible for  " + childName + "'s  actions");

                    var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (checkedButton != null)
                    {
                        string actionType = checkedButton.Text;
                        var actions = GetParentActions(childName, actionType);

                        foreach (var action in actions)
                            authorityResult.Items.Add(action);
                    }
                    else
                        authorityResult.Items.Add(childName + "'s  actions are neither nice or naughty.");
                }

            }
            else
            {
                MessageBox.Show("Invalid Input. The name must have 3 or more characters");
                searchInput.Text = string.Empty;
                searchInput.Focus();
            }

        }


        private void searchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void authorityResult_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = authorityResult.Columns[e.ColumnIndex].Width;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/razvan-olariu-bb23a8150/");
        }
    }
}

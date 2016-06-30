using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEvidenceTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ListDirectory(dirTree, "C:\\GetHosted");

            dirTree.AfterSelect += DirTreeOnAfterSelect;
            dirTree.AfterExpand += DirTree_AfterExpand;
        }

        private void DirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            var a = e;
            var b = sender;
        }

        private void DirTreeOnAfterSelect(object sender, TreeViewEventArgs treeViewEventArgs)
        {
            var a = treeViewEventArgs;
            var b = sender;
        }

        private static void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();

            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                try
                {


                    var directoryInfo = (DirectoryInfo)currentNode.Tag;
                    foreach (var directory in directoryInfo.GetDirectories())
                    {
                        var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                        currentNode.Nodes.Add(childDirectoryNode);
                        stack.Push(childDirectoryNode);
                    }
                    foreach (var file in directoryInfo.GetFiles())
                        currentNode.Nodes.Add(new TreeNode(file.Name));
                }
                catch (UnauthorizedAccessException)
                {
                    // Continue
                }
            }

            treeView.Nodes.Add(node);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб4._2
{
    class FormManager
    {
        public ITransport[] Transports { get; }
        public FormManager(ITransport[] transports)
        {
            this.Transports = transports;
        }
        public void Visualize(ListBox TargetList, TextBox SearchBox, int transportTypeIndex)
        {
            TargetList.Items.Clear();
            SearchBox.Clear();

            foreach (ITransport tr in Transports)
            {
                switch (transportTypeIndex)
                {
                    case 0:
                        TargetList.Items.Add(tr.Output());
                        break;
                    case 1:
                        if (tr.Output()[0] == 'P')
                            TargetList.Items.Add(tr.Output());
                        break;
                    case 2:
                        if (tr.Output()[0] == 'M')
                            TargetList.Items.Add(tr.Output());
                        break;
                    case 3:
                        if (tr.Output()[0] == 'T')
                            TargetList.Items.Add(tr.Output());
                        break;
                }
            }
        }

        public void SearchAndUpdateList(ListBox TargetList, string searchText, int transportTypeIndex)
        {
            TargetList.Items.Clear();

            foreach (ITransport tr in Transports)
            {
                char transportTypeChar = ' ';
                switch (transportTypeIndex)
                {
                    case 1:
                        transportTypeChar = 'P';
                        break;
                    case 2:
                        transportTypeChar = 'M';
                        break;
                    case 3:
                        transportTypeChar = 'T';
                        break;
                }

                if (transportTypeChar == ' ' || tr.Output()[0] == transportTypeChar)
                {
                    string output = tr.Output();

                    int loadCapacityIndex = output.LastIndexOf("LoadCapacity: ");
                    if (loadCapacityIndex != -1)
                    {
                        loadCapacityIndex += "LoadCapacity: ".Length;
                        int loadCapacityEndIndex = output.IndexOf('\t', loadCapacityIndex);
                        if (loadCapacityEndIndex == -1)
                        {
                            loadCapacityEndIndex = output.Length;
                        }
                        string loadCapacityString = output.Substring(loadCapacityIndex, loadCapacityEndIndex - loadCapacityIndex);

                        if (loadCapacityString == searchText)
                        {
                            TargetList.Items.Add(output);
                        }
                    }
                }
            }
        }
    }
}

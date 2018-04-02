using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpikeContainer.Spike_Dev_Express_Grid;
using SpikeContainer.Spike_Dev_Express_Grid.CodedEntity;
using SpikeContainer.Spike_Dev_Express_Grid.Data;

namespace SpikeContainer.Spike_Dev_Express_Grid
{
    public partial class GridLearnXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public GridLearnXtraForm()
        {
            InitializeComponent();
        }

        //MyGridWeightDataEntity _mgwdeDB = new MyGridWeightDataEntity();
        //GridWeightDataEntity _gwdeDB = new GridWeightDataEntity();
        //WeightEntity _weDb = new WeightEntity();

        List<Weights> _wEights = new List<Weights>();
        List<WeightInGrid> _wIg = new List<WeightInGrid>();
        List<GridWeightData> _gWd = new List<GridWeightData>();

        private void GridLearnXtraForm_Load(object sender, EventArgs e)
        {
            
        }

        private void GridLearnXtraForm_Shown(object sender, EventArgs e)
        {
            InitializeData();

            gridControl3.DataSource = _wEights;
            //gridControl3.DataMember = "Weights";

            gridControl2.DataSource = _gWd;
            //gridControl2.DataMember = "GridWeightData";

            gridControl1.DataSource = _wIg;
            //gridControl1.DataMember = "WeightInGrid";
        }

        private void InitializeData()
        {
            //Weights wts = new Weights(0,0,0);
            //_mgwdeDB.Weights.Add(wts);

            //GridWeightData gwd = new GridWeightData(0, 0, 0);
            //_gwdeDB.GridWeightEntity.Add(gwd);

            //WeightInGrid wig = new WeightInGrid(0, 0, 0);
            //_weDb.WeightInGrid.Add(wig);

            _wEights.Add(new Weights(0, 0, 0));

            _wIg.Add(new WeightInGrid(0, 0, 0));

            _gWd.Add(new GridWeightData(0, 0, 0));
        }
    }
}
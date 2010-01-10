﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuiWindowsForms.Relatorios.BoletoMensalidadeDataSetTableAdapters;

namespace GuiWindowsForms
{
    public partial class telaRelatorioBoletoMensalidade : Form
    {
        public telaRelatorioBoletoMensalidade()
        {
            InitializeComponent();
        }

        private void telaRelatorioBoletoMensalidade_Load(object sender, EventArgs e)
        {
            BoletoMensalidadeDataTableTableAdapter ta = new BoletoMensalidadeDataTableTableAdapter();
            GuiWindowsForms.Relatorios.BoletoMensalidadeDataSet.BoletoMensalidadeDataTableDataTable dataTable = ta.GetData(1);
            BoletoMensalidadeRelatorio1.SetDataSource((DataTable)dataTable);
            crystalReportViewer1.ReportSource = BoletoMensalidadeRelatorio1;
            BoletoMensalidadeRelatorio1.Refresh();
        }
    }
}

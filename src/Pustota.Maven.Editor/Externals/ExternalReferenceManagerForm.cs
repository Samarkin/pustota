﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Pustota.Maven.Editor.Models;
using Pustota.Maven.Editor.Resources;

namespace Pustota.Maven.Editor.Externals
{
	partial class ExternalReferenceManagerForm : Form
	{
		private readonly ISolution _solution;

		// REVIEW: remove 
		private readonly IProjectsRepository _repository;
		private readonly ExternalModulesRepository _externalModules;

		public ExternalReferenceManagerForm(ISolution solution)
		{
			if (solution == null)
				throw new ArgumentNullException("solution");

			_solution = solution;

			// REVIEW: encapsulate
			_repository = _solution.ProjectsRepository;
			_externalModules = _solution.ExternalModules;

			InitializeComponent();
			
			PopulateMavenExternalGrid();
		}

		private void PopulateMavenExternalGrid()
		{
			dataGridViewMavenExternal.DataSource = new BindingSource {DataSource = _externalModules.Items};
		}

		private void ButtonAddMavenExternalClick(object sender, EventArgs e)
		{
			ExternalModule externalModule = new ExternalModule();
			_externalModules.Add(externalModule);
			BindingSource bs = dataGridViewMavenExternal.DataSource as BindingSource;
			if (bs != null)
				bs.ResetBindings(true);
		}

		private void ButtonDeleteMavenExternalClick(object sender, EventArgs e)
		{
			BindingSource bs = dataGridViewMavenExternal.DataSource as BindingSource;
			if (bs != null)
			{
				ExternalModule externalModule = bs.Current as ExternalModule;
				if (externalModule != null)
				{
					_externalModules.Remove(externalModule);
					bs.ResetBindings(true);
				}
			}
		}

		private void ExternalReferenceManagerFormFormClosing(object sender, FormClosingEventArgs e)
		{
			dataGridViewMavenExternal.EndEdit();
			var result = MessageBox.Show(MessageResources.DoYouWantToSaveChanges,
					CommonResources.PermanentChanges, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			switch (result)
			{
				case DialogResult.Yes:
					_externalModules.AllModules.Save();
					break;
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
			}
		}

		private void DataGridViewMavenExternalRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			var currentRow = dataGridViewMavenExternal.Rows[e.RowIndex];
			var current = currentRow.DataBoundItem as ExternalModule;
			if (current != null)
				DecorateRow(currentRow, !_repository.IsItUsed(current));
		}

		private void DecorateRow(DataGridViewRow currentRow, bool isObsoleted)
		{
			currentRow.DefaultCellStyle.BackColor = isObsoleted ? Color.LightGray : Color.White;
		}
	}
}


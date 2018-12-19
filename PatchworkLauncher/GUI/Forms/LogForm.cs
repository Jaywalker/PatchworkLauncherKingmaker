﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Patchwork.Utility;
using Patchwork.Utility.Binding;
using PatchworkLauncher.Extensions;

namespace PatchworkLauncher
{
	public partial class LogForm : Form
	{
		public IBindable<IList<ProgressObject>> List { get; }

		public LogForm(ProgressObject list)
		{
			List = Bindable.List(new ProgressList(list));
			InitializeComponent();
		}

		private void LogForm_Load(object sender, EventArgs e)
		{
			guiPanel.FlowDirection = FlowDirection.TopDown;
			guiPanel.Controls.Clear();
			Func<ProgressObject, Control> progressTemplate = po =>
			                                                 {
				                                                 Label topLabel = new Label {Margin = new Padding(0, 5, 0, 5), Font = new Font(Font.FontFamily, 12f, FontStyle.Bold), Width = guiPanel.Width - 30, AutoSize = true};
				                                                 Label botLabel = new Label {Width = guiPanel.Width - 30, AutoSize = true};
				                                                 ProgressBar progBar = new ProgressBar {Margin = new Padding(0, 5, 0, 0), Width = guiPanel.Width - 30, AutoSize = true};

				                                                 po.TaskTitle.Binding = GuiBindings.Bind(topLabel, x => x.Text).ToBinding(BindingMode.FromTarget);
				                                                 po.TaskText.Binding = GuiBindings.Bind(botLabel, x => x.Text).ToBinding(BindingMode.FromTarget);
				                                                 po.Total.Binding = GuiBindings.Bind(progBar, x => x.Maximum).ToBinding(BindingMode.FromTarget);
				                                                 po.Current.Binding = GuiBindings.Bind(progBar, x => x.Value).ToBinding(BindingMode.FromTarget);

				                                                 progBar.Maximum = po.Total.Value;
				                                                 progBar.Value = po.Current.Value;
				                                                 FlowLayoutPanel flowThing = new FlowLayoutPanel {FlowDirection = FlowDirection.TopDown, Margin = new Padding(10, 5, 10, 5), Width = guiPanel.Width - 30};
				                                                 flowThing.Controls.AddRange(new[] {(Control) topLabel, botLabel, progBar});
				                                                 return flowThing;
			                                                 };
			List.Binding = guiPanel.Controls.CastList().ProjectList(progressTemplate).ToBindable().WithDispatcher(act => Invoke(act)).ToBinding(BindingMode.FromTarget);
		}

//		public ILogger Logger {
//			get;
//		}

		public void Test()
		{
		}

		private void guiPanel_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}

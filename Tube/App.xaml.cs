﻿namespace Tube;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		VersionTracking.Track();
		
		MainPage = new AppShell();
	}
}

﻿using Assets.Scripts.Utils.Views;

namespace Assets.Scripts.Tests.Views
{
	public class OptionsView : ViewBase
	{
        public MainMenuView MenuView;

        public void OnBack()
        {
            SwitchTo(MenuView);
        }

        protected override void OnBackKey()
        {
            OnBack();
        }
	}
}
using System;
using System.Collections.Generic;
using CryoDI;
using Source.MainScen;

namespace Source
{
    public class MainMenuController : IController
    {
        [Dependency] private MainMenuScreen _mainMenu { get; set; }

        private DictFunctionsScreen _dictFunctions;
        private DownMenuScreen _downMenu;
        private SettingsScreen _settings;
        private HomeScreen _home;


        private Dictionary<Type, IView> viewsStates;
        private IView currentState;


        private void SetDependencies()
        {
            _dictFunctions = _mainMenu.DictFunctions;
            _settings = _mainMenu.Settings;
            _home = _mainMenu.Home;

            _downMenu = _mainMenu.DownMenu;
            _downMenu.OnClickToDictionary += () => SetState(_dictFunctions);

            _downMenu.OnClickToHome += () => SetState(_home);
            _downMenu.OnClickToSettings += () => SetState(_settings);
        }

        public void Init()
        {
            SetDependencies();
            //by default:
            SetState(_home);
        }

        private void SetState(IView state)
        {
            currentState?.Hide();

            currentState = state;
            currentState.Show();
        }


        public void Run()
        {
        }
    }
}
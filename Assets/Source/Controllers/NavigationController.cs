using System;
using System.Collections.Generic;
using System.ComponentModel;
using Source.MainScen;
using UnityEngine;
using CryoDI;

namespace Source
{
    public class NavigationController : IController
    {
        [Dependency] private MainMenuScreen MainMenu { get; set; }
        [Dependency] private SearchWordScreen SearchWord { get; set; }
        [Dependency] private SetWordScreen SetWord { get; set; }

        private IView CurentState;
        private IView StateByDefault;

        private Dictionary<Type, IView> MapAllStates;
        private Dictionary<Type, IView> MapPreviousStates;
        private IView PreviousStateByDefault;

        private TestDi _testDi;

        private Camera _camera;

    

        public void Init()
        {
            MapAllStates = new Dictionary<Type, IView>();
            MapAllStates[typeof(MainMenuScreen)] = MainMenu;
            MapAllStates[typeof(SearchWordScreen)] = SearchWord;
            MapAllStates[typeof(SetWordScreen)] = SetWord;

            MapPreviousStates = new Dictionary<Type, IView>();
            
            SubscribeClikToBack();
            HideAllStates();
            StateByDefault = MainMenu;
            SetPreviousStatesByDefault(StateByDefault);

            SetState(StateByDefault);

            MainMenu.DictFunctions.OnClickToSearchWord += () => SetState(SearchWord);
            SearchWord.OnClickToSetWord += () => SetState(SetWord);

            SetWord.OnClickToAddWord += () => SetState(StateByDefault);

            
        }

        private void SetState(IView state, bool setPreviousState = true)
        {
            CurentState?.Hide();

            if (setPreviousState)
            {
                MapPreviousStates[state.GetType()] = CurentState;
            }

            CurentState = state;
            CurentState.Show();
        }

        public void Run()
        {
        }

        private void ChangeStateToPrevious()
        {
            SetState(MapPreviousStates[CurentState.GetType()], false);
        }

        private void SubscribeClikToBack()
        {
            foreach (var state in MapAllStates)
                MapAllStates[state.Key].OnClickToBack += ChangeStateToPrevious;
        }

        private void HideAllStates()
        {
            foreach (var state in MapAllStates)
                MapAllStates[state.Key].Hide();
        }

        private void SetPreviousStatesByDefault(IView defolt)
        {
            foreach (var state in MapAllStates)
                MapPreviousStates[state.Key] = defolt;
        }
    }
}
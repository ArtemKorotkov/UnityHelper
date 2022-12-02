using System;
using CryoDI;
using Source.MainScen;
using Unity.VisualScripting;
using UnityEngine;

namespace Source
{
    public class MainContext : SceneContext
    {
        public CryoContainer ViewContainer;
        
        protected override void SetupContainer(CryoContainer container)
        {
            container.RegisterSceneObject<SearchWordScreen>("Canvases/SearchWord", LifeTime.Scene);
            container.RegisterSceneObject<MainMenuScreen>("Canvases/MainMenu", LifeTime.Scene);
            container.RegisterSceneObject<SetWordScreen>("Canvases/SetWord", LifeTime.Scene);

            ViewContainer = container;
        } 
        
        public class Initialisation
        {
            
        }
        
    }
}   
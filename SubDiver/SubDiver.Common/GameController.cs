﻿using System;
using CocosSharp;
using System.Collections.Generic;

namespace SubDiver.Common {
  public static class GameController
  {
    public static CCGameView GameView
    {
      get;
      private set;
    }

    public static void Initialize (CCGameView gameView)
    {
      GameView = gameView;

      var contentSearchPaths = new List<string> () { "Fonts", "Sounds" };

      contentSearchPaths.Add("Images");
      GameView.ContentManager.SearchPaths = contentSearchPaths;

      // We use a lower-resolution display to get a pixellated appearance
      int width = 384;
      int height = 512;
      GameView.DesignResolution = new CCSizeI (width, height);

      var scene = new TitleScene (GameView);
      GameView.Director.RunWithScene (scene);
    }

    public static void GoToScene(CCScene scene)
    {
      GameView.Director.ReplaceScene(scene);
    }
  }
}


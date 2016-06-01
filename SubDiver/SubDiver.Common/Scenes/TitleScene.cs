using System;
using CocosSharp;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubDiver.Common {
  
  public class TitleScene : CCScene {
    CCLayer layer;
    CCLabel begin;

    public TitleScene(CCGameView gameView) : base(gameView) {
      layer = new CCLayer();
      this.AddChild(layer);

      CreateText();

      CreateTouchListener();
    }

    private void CreateText(){
      begin = new CCLabel("Tap to begin", "Arial", 30, CCLabelFormat.SystemFont);
      begin.PositionX = layer.ContentSize.Width / 2.0f;
      begin.PositionY = layer.ContentSize.Height / 2.0f;

      layer.AddChild(begin);
    }

    private void CreateTouchListener(){
      var touchListener = new CCEventListenerTouchAllAtOnce();
      touchListener.OnTouchesBegan = HandleTouchesBegan;
      layer.AddEventListener(touchListener);
    }

    private void HandleTouchesBegan(List<CCTouch> arg1, CCEvent arg2){
      var newScene = new CCScene(GameController.GameView);
      newScene.AddLayer(new GameLayer());
      GameController.GoToScene(newScene);
    }
  }
}


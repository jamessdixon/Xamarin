using System;
using ARKit;
using SceneKit;
using ArKitSampleApp.ArKitRelated.Delegates;

namespace ArKitSampleApp.ArKitRelated
{
    public class ArSceneGenerator
    {
        // Method responsible for creating new AR Scene:
        public void GenerateArScene(ARSCNView sceneView)
        {
            // First we need to create scene with object loaded from local file:
            var scene = SCNScene.FromFile("art.scnassets/ship");

            // Then we need to assign this scene to SceneView from our ViewController:
            sceneView.Scene = scene;

            // Developer has possibility to set debug options.
            // For instance to display XYZ axis or to show planes points in front of camera:

            //sceneView.DebugOptions = ARSCNDebugOptions.ShowWorldOrigin
            //| ARSCNDebugOptions.ShowFeaturePoints;

            // Here we are assigning delegate to session to get infromation about current session state:
            sceneView.Session.Delegate = new ArSessionDelegate();
        }

        // Once we create scene we need to position our AR model in it:
        public void PositionSceneObject(ARSCNView sceneView)
        {
            // Each session has to be configured.
            //  We will use ARWorldTrackingConfiguration to have full access to device orientation,
            // rear camera, device position and to detect real-world flat surfaces:
            var configuration = new ARWorldTrackingConfiguration
            {
                PlaneDetection = ARPlaneDetection.Horizontal,
                LightEstimationEnabled = true
            };

            // Once we have our configuration we need to run session with it.
            // ResetTracking will just reset tracking by session to start it again from scratch:
            sceneView.Session.Run(configuration, ARSessionRunOptions.ResetTracking);

            // Next we need to find main "node" in the .dae file. In this case it is called "ship":
            var shipNode = sceneView.Scene.RootNode.FindChildNode("ship", true);

            // Then we have to set position of AR object - below I would like to display it in front of camera:
            shipNode.Position = new SCNVector3(0.0f, 0.0f, -20f);

            // Next we need to add ship object to scene:
            sceneView.Scene.RootNode.AddChildNode(shipNode);

            // At the end I configured simple rotating animation to rotate ship object in front of camera:
            shipNode.RunAction(SCNAction.RepeatActionForever(SCNAction.RotateBy(0f, 4f, 0, 5)));
        }
    }
}

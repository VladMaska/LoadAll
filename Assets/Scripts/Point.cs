using UnityEngine;

public class Point : INewPoint {
    
    public GameObject PointPrefab { get; set; }

    public Point( string gameObjectName ) => PointPrefab = Resources.Load<GameObject>( gameObjectName );

    public void Set( Vector3 position ){
        
        var obj = Object.Instantiate( PointPrefab, position, Quaternion.identity );
        obj.name = PointPrefab.name;

    }

}
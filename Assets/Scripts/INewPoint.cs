using UnityEngine;

public interface INewPoint {

    public GameObject PointPrefab { get; set; }
    
    void Set( Vector3 position );
    
}
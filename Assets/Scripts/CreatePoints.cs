using UnityEngine;

public class CreatePoints : MonoBehaviour {

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    // private readonly INewPoint _newPoint = new Point( "Point" );

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Start(){

        for ( var i = 0; i < 100; i++ ){
            
            var position = new Vector3( Random.Range( -10f, 10f ), .3f, Random.Range( -10f, 10f ) );
            new Point( "Point" ).Set( position );
            
        }
        
    }

}
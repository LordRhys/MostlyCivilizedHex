using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

  // Use this for initialization
  void Start () {
    GenerateMap();
  }

  public GameObject HexPrefab;
  
  public void GenerateMap() {
    for (int column = 0; column < 10; column++)
    {
      for (int row = 0; row < 10; row++)
      {
        // Instantiate a Hex
        Hex h = new Hex( column, row );

        Instantiate( 
          HexPrefab,
          h.Position(),
          Quaternion.identity,
          this.transform
        );
      }
    }
  }
}

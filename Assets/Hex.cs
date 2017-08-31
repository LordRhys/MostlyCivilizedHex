using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Hex class defines the grid position, world space position, size,
/// neighbors, etc... of a Hex Tile. However, it does NOT interact with
/// Unity directly in any way.
/// </summary>
public class Hex {

  public Hex(int q, int r) {
    this.Q = q;
    this.R = r;
    this.S = -(q + r);
  }

  public readonly int Q; // Column
  public readonly int R; // Row
  public readonly int S; // Q + R + S = 0 => S = - (Q + R)

  static readonly float WIDTH_MULTIPLIER = Mathf.Sqrt( 3 ) / 2;

  /// <summary>
  /// Returns the world space position of this Hex
  /// </summary>
  /// <returns></returns>
  public Vector3 Position() {
    float radius = 1f;
    float height = radius * 2;
    float width = WIDTH_MULTIPLIER * height;

    float vert = height * 0.75f;
    float horiz = width;

    return new Vector3(
            horiz * (this.Q + this.R/2f),
            0,
            vert * this.R
          ); 
          
  }
}

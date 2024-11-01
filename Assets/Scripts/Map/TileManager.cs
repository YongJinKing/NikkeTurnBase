using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{
    #region Properties
    #region Private
    #endregion
    #region Protected
    #endregion
    #region Public
    public Grid grid;
    public Tilemap tileMap;
    #endregion
    #region Events
    #endregion
    #endregion

    #region Constructor
    #endregion

    #region Methods
    #region Private
    #endregion
    #region Protected
    #endregion
    #region Public
    #endregion
    #endregion

    #region EventHandlers
    #endregion

    #region Coroutines
    #endregion

    #region MonoBehaviour
    //for test
    private void Start()
    {
        Debug.Log("TileManager.Start()");
        for (int i = 0; i < tileMap.transform.childCount; i++)
        {
            Debug.Log(grid.LocalToCell(tileMap.transform.GetChild(i).transform.position));
        }
        Debug.Log("TileManager.Start() End");
    }
    #endregion
}

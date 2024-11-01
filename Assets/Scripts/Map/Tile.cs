using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    #region Properties
    #region Private
    #endregion
    #region Protected
    #endregion
    #region Public
    public TileState tileState
    {
        get; protected set;
    }
    /// <summary>
    /// Ÿ�� ��ǥ
    /// </summary>
    public Point pos;
    public int height;
    /// <summary>
    /// Ÿ�� �ٷ� �� Vector3 ��ǥ
    /// </summary>
    public Vector3 center
    {
        get { return new Vector3(pos.x, height, pos.y); }
    }
    /// <summary>
    /// Ÿ�� ���� �ִ� ��ü
    /// </summary>
    public GameObject content;
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
    #endregion
}

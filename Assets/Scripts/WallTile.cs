﻿/*
 * Filename:		WallTile.cs
 * Programmer:		Colin McMillan
 * Date:			July 2015
 * Description:		Describes advanced behaviours of wall tiles, creating more
 * 					complicated graphical structures - continuous walls instead of discrete
 * 					individual blocks. Not presently in use, more of a hopefully-someday.
 */

using UnityEngine;
using System.Collections;


// Name:	WallTile
// Purpose:	
public class WallTile : MonoBehaviour
{
	public Sprite TopLeft;
	public Sprite TopMid;
	public Sprite TopRight;

	public Sprite MidLeft;
	public Sprite FourSides;
	public Sprite MidRight;

	public Sprite BotLeft;
	public Sprite BotMid;
	public Sprite BotRight;

	public Sprite HorizLeft;
	public Sprite HorizMid;
	public Sprite HorizRight;

	public Sprite VertTop;
	public Sprite VertMid;
	public Sprite VertBot;

	public Sprite NoSides;
	public Sprite EightSides;
	
	// Use this for initialization
	void Start ()
	{

	}
}

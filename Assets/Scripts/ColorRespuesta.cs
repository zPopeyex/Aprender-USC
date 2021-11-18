using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ColorRespuesta : MonoBehaviour
{
    public static RawImage NumeroRespuestaColor;
    public RawImage ImagenRespuesta1;
    public RawImage ImagenRespuesta2;
    public RawImage ImagenRespuesta3;
    public RawImage ImagenRespuesta4;
    public Texture2D Verde;
    public Texture2D Rojo;
    public Texture2D Blanco;

    public static int NumeroBoton = 0;

    public void ObtenerNumeroBoton(int Numero)
    {
   
        NumeroBoton = Numero;

        if (NumeroBoton == 1)
        {
            NumeroRespuestaColor = ImagenRespuesta1;
            ImagenRespuesta2.texture = Blanco;
            ImagenRespuesta3.texture = Blanco;
            ImagenRespuesta4.texture = Blanco;
        }
        if (NumeroBoton == 2)
        {
            NumeroRespuestaColor = ImagenRespuesta2;
            ImagenRespuesta1.texture = Blanco;
            ImagenRespuesta3.texture = Blanco;
            ImagenRespuesta4.texture = Blanco;
        }
        if (NumeroBoton == 3)
        {
            NumeroRespuestaColor = ImagenRespuesta3;
            ImagenRespuesta1.texture = Blanco;
            ImagenRespuesta2.texture = Blanco;
            ImagenRespuesta4.texture = Blanco;
        }
        if (NumeroBoton == 4)
        {
            NumeroRespuestaColor = ImagenRespuesta4;
            ImagenRespuesta1.texture = Blanco;
            ImagenRespuesta2.texture = Blanco;
            ImagenRespuesta3.texture = Blanco;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(Principal.PreguntasPlazoleta[0].correcta == NumeroBoton)
        {
            NumeroRespuestaColor.texture = Verde;

        }
        if (NumeroBoton > 0 && NumeroBoton != Principal.PreguntasPlazoleta[0].correcta)
        {
            NumeroRespuestaColor.texture = Rojo;

        }
        if (NumeroBoton == 0)
        {
            NumeroRespuestaColor.texture = Blanco;
        }

    }

}

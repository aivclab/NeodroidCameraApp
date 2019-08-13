using UnityEngine;
using UnityEngine.UI;

/// <summary>
///
/// </summary>
public class PlayMovieTextureOnUi : MonoBehaviour {
  /// <summary>
  ///
  /// </summary>
  [SerializeField]
  RawImage raw_image;

  void Awake() {
    if (this.raw_image != null) {
      if (this.raw_image.texture == null) {
        var webcam_texture = new WebCamTexture();
        this.raw_image.texture = webcam_texture;
        this.raw_image.material.mainTexture = webcam_texture;
        webcam_texture.Play();
      }
    }
  }
}
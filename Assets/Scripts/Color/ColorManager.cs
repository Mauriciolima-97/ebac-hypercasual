using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class ColorManager : Singleton<ColorManager>
{
    public List<Material> materials;
    public List<ColorSetup> colorSetups;

    public void ChangerColorByType(ArtManager.ArtType artType)
    {
        var setup = colorSetups.Find(i => i.artType == artType);

        if (setup == null)
        {
            Debug.LogError("ColorSetup não encontrado para: " + artType);
            return;
        }

        for (int i = 0; i < materials.Count && i < setup.colors.Count; i++)
        {
            materials[i].SetColor("_Color", setup.colors[i]);
        }
    }
}

[System.Serializable]
public class ColorSetup
{
    public ArtManager.ArtType artType;
    public List<Color> colors;
}

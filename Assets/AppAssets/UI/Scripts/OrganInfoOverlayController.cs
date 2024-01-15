using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrganInfoOverlayController : MonoBehaviour
{
    [SerializeField]
    GameObject _overlay;

    [SerializeField]
    TMP_Text _title;

    [SerializeField]
    TMP_Text _subtitle;

    [SerializeField]
    TMP_Text _description;

    private static readonly Dictionary<HumanOrgans, HumanOrganInfo> _organsInfo = new Dictionary<HumanOrgans, HumanOrganInfo>()
        {
            { HumanOrgans.Heart, new HumanOrganInfo { title="Heart", subtitle="Inner organ for the circulation of blood", description="The heart is a muscular organ in most animals. This organ pumps blood through the blood vessels of the circulatory system. The pumped blood carries oxygen and nutrients to the body, while carrying metabolic waste such as carbon dioxide to the lungs." } },
            { HumanOrgans.Liver, new HumanOrganInfo { title = "Liver", subtitle = "Vertebrate organ involved in metabolism", description = "The liver is a major metabolic organ only found in vertebrate animals, which performs many essential biological functions such as detoxification of the organism, and the synthesis of proteins and biochemicals necessary for digestion and growth." } },
            { HumanOrgans.Lungs, new HumanOrganInfo { title = "Lungs", subtitle = "Essential respiration organ in many air-breathing animals", description = "The lungs are the most important organs of the respiratory system in humans and most other animals, including some snails and a small number of fish. In mammals and most other vertebrates, two lungs are located near the backbone on either side of the heart." } },
            { HumanOrgans.Pancreas, new HumanOrganInfo { title = "Pancreas", subtitle = "Glandular organ that plays a role in the digestive and endocrine systems of vertebrates", description = "The pancreas is an organ of the digestive system and endocrine system of vertebrates. In humans, it is located in the abdomen behind the stomach and functions as a gland. The pancreas is a mixed or heterocrine gland, i.e., it has both an endocrine and a digestive exocrine function. 99% of the pancreas is exocrine and 1% is endocrine." } },
            { HumanOrgans.Stomach, new HumanOrganInfo { title = "Stomach", subtitle = "Digestive organ", description = "The stomach is a muscular, hollow organ in the gastrointestinal tract of humans and many other animals, including several invertebrates. The stomach has a dilated structure and functions as a vital organ in the digestive system." } }
        };

    public static OrganInfoOverlayController Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null & Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        _overlay.SetActive(false);
    }

    public void UpdateOverlayContentByOrgan(HumanOrgans organ)
    {
        var organInfo = _organsInfo[organ];

        _title.text = organInfo.title;
        _subtitle.text = organInfo.subtitle;
        _description.text = organInfo.description;
    }

    public void ShowOverlay()
    {
        _overlay.SetActive(true);
    }

    public void HideOverlay()
    {
        _overlay.SetActive(false);
    }
}

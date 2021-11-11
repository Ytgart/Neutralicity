using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Zenject;

public class GameRender : MonoBehaviour
{
    [Inject] private Game _game;
    [SerializeField] private GameObject _cityModel;
    [SerializeField] private GameObject _cityHouse;
    [Inject] private DiContainer _diContainer;

    public void RenderCities(List<City> _cities) 
    {
        var i = 0;
        foreach (City item in _cities)
        {
            var newObject = _diContainer.InstantiatePrefab(_cityModel, new Vector3(item.Location.X, item.Location.Y, 0), Quaternion.identity, null);
            newObject.GetComponent<InteractableObject>().Type = InteractableType.city;
            newObject.GetComponent<InteractableObject>().Index = i;
            i++;
        }
    }
    
    public void RenderCitiesGrowth(List<City> _cities)
    {
        float randX = new float();
        float randY = new float();

        foreach (City item in _cities)
        {
            randX = Random.Range(-3.0f, 3.0f);
            randY = Random.Range(-3.0f, 3.0f);

            if (item.CityResources.Resources[3].Amount % 3 == 0) // смотрим население и проверяем
            {
                Instantiate(_cityHouse, new Vector3(item.Location.X + randX, item.Location.Y + randY, 0), Quaternion.identity);
                item.housePositions.Add(new System.Numerics.Vector3(randX, randY, 0));
                continue;
            }
            // зарефакторить с 1 строки до 54
            while(item.housePositions.Where(x => x == new System.Numerics.Vector3(randX, randY, 0)).Any())
            {
                randX = Random.Range(-3.0f, 3.0f);
                randY = Random.Range(-3.0f, 3.0f);

                if (item.CityResources.Resources[3].Amount % 3 == 0) // смотрим население и проверяем
                {
                    Instantiate(_cityHouse, new Vector3(item.Location.X + randX, item.Location.Y + randY, 0), Quaternion.identity);
                    item.housePositions.Add(new System.Numerics.Vector3(randX, randY, 0));
                }
            }
            
        }
    }
}

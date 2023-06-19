using UnityEngine;

public class PokemonSpawner : MonoBehaviour
{
    public GameObject pokemonPrefab; // Prefab of the Pokemon to spawn

    private void OnMouseDown()
    {
        SpawnPokemon();
    }

    private void SpawnPokemon()
    {
        // Spawn the Pokemon prefab at the current position of the image tracker
        Instantiate(pokemonPrefab, transform.position, transform.rotation);
    }
}

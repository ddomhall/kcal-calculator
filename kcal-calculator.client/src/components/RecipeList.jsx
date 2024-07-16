import { useEffect, useState } from 'react';

export default function RecipeList() {
    const [recipes, setRecipes] = useState();

    useEffect(() => {
        populateRecipes();
    }, []);

    async function populateRecipes() {
        const response = await fetch('recipes');
        const data = await response.json();
        setRecipes(data);
    }

    return (
        <table>
            <thead>
                <tr>
                    <th>name</th>
                </tr>
            </thead>
            <tbody>
                {recipes && recipes.map(recipe => (
                    <tr key={recipe.id}>
                        <td>{recipe.name}</td>
                        <td><button>edit</button></td>
                        <td><button>delete</button></td>
                    </tr>
                ))}
                <tr><td colSpan={3}><button style={{ width: "100%" }}>+</button></td></tr>
            </tbody>
        </table>
    )
}

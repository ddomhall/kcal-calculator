import { useEffect, useState } from 'react';
import RecipeList from './components/RecipeList';
import IngredientList from './components/IngredientList';

export default function App() {
    const [page, setPage] = useState("day")
    const [ingredients, setIngredients] = useState();
    const [recipes, setRecipes] = useState();
    const [selection, setSelection] = useState();

    useEffect(() => {
        populateIngredients();
        populateRecipes();
    }, []);

    async function populateIngredients() {
        const response = await fetch('ingredients');
        const data = await response.json();
        setIngredients(data);
    }

    async function populateRecipes() {
        const response = await fetch('recipes');
        const data = await response.json();
        setRecipes(data);
    }


    function getView() {
        switch (page) {
            case "ingredients":
                return <IngredientList ingredients={ingredients} setSelection={setSelection} />
            case "recipes":
                return <RecipeList recipes={recipes} setSelection={setSelection} />
            default:
                return "day"
        }
    }

    return (
        <div id='mainContainer'>
            <main>
                <button onClick={() => setPage("ingredients")}>ingredients</button>
                <button onClick={() => setPage("recipes")}>recipes</button>
                <button onClick={() => setPage("day")}>day</button>
                <br />
                {getView()}
            </main>
            <aside>
                {selection ? selection.name : "nothing selected"}
            </aside>
        </div>
    )

}

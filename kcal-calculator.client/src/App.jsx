import { useState } from 'react';
import IngredientList from './components/IngredientList';
import RecipeList from './components/RecipeList';

export default function App() {
    const [page, setPage] = useState("day")

    function getView() {
        switch (page) {
            case "ingredients":
                return <IngredientList />
            case "recipes":
                return <RecipeList />
            default:
                return "day"
        }
    }

    return (
        <>
            <button onClick={() => setPage("ingredients")}>ingredients</button>
            <button onClick={() => setPage("recipes")}>recipes</button>
            <button onClick={() => setPage("day")}>day</button>
            <br />
            {getView()}
        </>
    )

}

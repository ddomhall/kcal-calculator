import { useEffect, useState } from 'react';

export default function App() {
    const [ingredients, setIngredients] = useState();

    useEffect(() => {
        populateIngredients();
    }, []);

    async function populateIngredients() {
        const response = await fetch('ingredients');
        const data = await response.json();
        setIngredients(data);
    }

    return <button onClick={() => console.log(ingredients)}>test</button>

}

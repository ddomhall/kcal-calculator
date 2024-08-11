export default function IngredientList({ ingredients, setSelection }) {
    return (
        <table>
            <thead>
                <tr>
                    <th>name</th>
                    <th>protein</th>
                    <th>carbs</th>
                    <th>fats</th>
                </tr>
            </thead>
            <tbody>
                {ingredients && ingredients.map(ingredient => (
                    <tr key={ingredient.id}>
                        <td> <button onClick={() => setSelection(ingredient)}>{ingredient.name}</button> </td>
                        <td>{ingredient.protein}</td>
                        <td>{ingredient.carbs}</td>
                        <td>{ingredient.fats}</td>
                        <td><button>edit</button></td>
                        <td><button>delete</button></td>
                    </tr>
                ))}
                <tr><td colSpan={6}><button style={{ width: "100%" }}>+</button></td></tr>
            </tbody>
        </table>
    )
}

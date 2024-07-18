export default function RecipeList({ recipes, setSelection }) {
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
                        <td> <button onClick={() => setSelection(recipe)}>{recipe.name}</button> </td>
                        <td><button>edit</button></td>
                        <td><button>delete</button></td>
                    </tr>
                ))}
                <tr><td colSpan={3}><button style={{ width: "100%" }}>+</button></td></tr>
            </tbody>
        </table>
    )
}

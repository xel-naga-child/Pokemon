import { Tree } from 'antd';
import { usePokeTree } from './PokeTree.cb.ts'

export const PokeTree = () => {
    const method = usePokeTree();
    const treeData = method.pokemonList.map((pokemon) => ({
        title: pokemon.name,
        key: pokemon.id,
    }));

        return <Tree treeData={treeData} />
}
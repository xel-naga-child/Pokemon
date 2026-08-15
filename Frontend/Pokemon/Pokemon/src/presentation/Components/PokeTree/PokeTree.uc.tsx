import { Tree } from 'antd';

export const PokeTree = () => {

    let treeData = [
        {key: '0', title: 'Pokemon'},
        {key: '1', title: 'Pokemon1'},
        {key: '2', title: 'Pokemon2'}
    ];

    return <Tree treeData={treeData} />
}
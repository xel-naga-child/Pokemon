import { Tree } from 'antd'

export default function PokeTree() {    

    return (<Tree treeData={[
  {
    "title": "parent 1",
    "key": "0-0",
    "icon": {
      "type": "",
      "key": null,
      "ref": null,
      "props": {}
    },
    "children": [
      {
        "title": "leaf",
        "key": "0-0-0",
        "icon": {
          "type": {},
          "key": null,
          "ref": null,
          "props": {}
        }
      },
      {
        "title": "leaf",
        "key": "0-0-1"
      }
    ]
  }
]}/>)
}
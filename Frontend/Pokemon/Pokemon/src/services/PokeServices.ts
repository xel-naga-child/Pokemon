import axios from 'axios';
const VITE_API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

export const PokemonListService = async (offset: number, limit: number) => {

    const response = await axios.get(`${VITE_API_BASE_URL}Pokemon/list?offset=${offset}&limit=${limit}`);

    return response.data;

}


export const PokemonListDetailService = async (offset: number, limit: number) => {

    const response = await axios.get(`${VITE_API_BASE_URL}Pokemon/list/details?offset=${offset}&limit=${limit}`);

    return response.data;
}
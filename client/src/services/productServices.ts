import { ProductDataType } from '../interfaces/GlobalInterfaces';

const API_BASE_URL = 'https://localhost:7052/api';

export const getAllProducts = async (
	pageNumber?: number,
	pageSize?: number,
	orderBy?: string,
	minPriceVal?: number,
	maxPriceVal?: number
): Promise<ProductDataType> => {
	try {
		let url = `${API_BASE_URL}/product`;

		if (pageNumber && pageSize) {
			url += `?pageNumber=${pageNumber}&pageSize=${pageSize}`;
		}

		if (orderBy) {
			url += `${pageNumber && pageSize ? '&' : '?'}orderBy=${orderBy}`;
		}

		if (minPriceVal !== undefined && maxPriceVal !== undefined) {
			url += `${
				pageNumber || orderBy ? '&' : '?'
			}minPrice=${minPriceVal}&maxPrice=${maxPriceVal}`;
		}

		const response = await fetch(url);

		if (!response.ok) {
			throw new Error('Error getting the products');
		}

		const data = await response.json();

		const {
			products,
			totalCount,
			pageSize: responsePageSize,
			minPrice,
			maxPrice,
		} = data.result;

		const totalPages = Math.ceil(totalCount / responsePageSize);

		return { products, totalPages, minPrice, maxPrice };
	} catch (error) {
		console.error(error);
		throw error;
	}
};

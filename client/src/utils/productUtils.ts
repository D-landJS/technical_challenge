import { getAllProducts } from '../services/productServices';
import { Dispatch } from 'react';
import { ProductActionType, IProduct } from '../interfaces/GlobalInterfaces';

export const sortChange = async (
	sortBy: string,
	currentPage: number,
	productsPerPage: number,
	minPrice: number,
	maxPrice: number,
	products: IProduct[],
	dispatch: Dispatch<ProductActionType>
) => {
	try {
		let sortedProducts;

		if (sortBy) {
			let filteredProducts;
			if (minPrice !== 0 || maxPrice !== 0) {
				filteredProducts = await getAllProducts(
					1,
					productsPerPage,
					sortBy,
					minPrice,
					maxPrice
				);
				dispatch({ type: 'SET_CURRENT_PAGE', payload: 1 });
			} else {
				filteredProducts = await getAllProducts(
					currentPage,
					productsPerPage,
					sortBy
				);
			}
			sortedProducts = filteredProducts.products;
		} else {
			// No sort order specified, use original products
			sortedProducts = products;
		}

		dispatch({ type: 'SET_PRODUCTS', payload: sortedProducts });
		if (sortBy) dispatch({ type: 'SET_SORT_BY', payload: sortBy });
	} catch (error) {
		console.error(error);
	}
};

export const filterChange = async (
	min: number,
	max: number,
	rangePrice: { minPriceVal: number; maxPriceVal: number },
	sortBy: string,
	currentPage: number,
	productsPerPage: number,

	dispatch: Dispatch<ProductActionType>
) => {
	try {
		if (
			min < rangePrice.minPriceVal ||
			min > max ||
			max > rangePrice.maxPriceVal
		) {
			return;
		}

		dispatch({ type: 'SET_MIN_PRICE', payload: min });
		dispatch({ type: 'SET_MAX_PRICE', payload: max });

		let filteredProducts;

		if (sortBy && (currentPage !== 1 || min !== 0 || max !== 0)) {
			filteredProducts = await getAllProducts(
				1,
				productsPerPage,
				sortBy,
				min,
				max
			);
			dispatch({ type: 'SET_CURRENT_PAGE', payload: 1 });
		} else {
			filteredProducts = await getAllProducts(
				currentPage,
				productsPerPage,
				sortBy,
				min,
				max
			);
		}

		dispatch({ type: 'SET_PRODUCTS', payload: filteredProducts.products });
		dispatch({
			type: 'SET_TOTAL_PAGES',
			payload: filteredProducts.totalPages,
		});
	} catch (error) {
		console.error(error);
	}
};

export const pageChange = async (
	pageNumber: number,
	minPrice: number,
	maxPrice: number,
	productsPerPage: number,
	sortBy: string,
	dispatch: Dispatch<ProductActionType>
) => {
	try {
		let paginatedProducts;

		if (minPrice !== 0 || maxPrice !== 0) {
			paginatedProducts = await getAllProducts(
				pageNumber,
				productsPerPage,
				sortBy,
				minPrice,
				maxPrice
			);
		} else {
			paginatedProducts = await getAllProducts(
				pageNumber,
				productsPerPage,
				sortBy
			);
		}

		dispatch({ type: 'SET_PRODUCTS', payload: paginatedProducts.products });
		dispatch({ type: 'SET_CURRENT_PAGE', payload: pageNumber });
	} catch (error) {
		console.error(error);
	}
};

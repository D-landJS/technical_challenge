import { Dispatch } from 'react';

export interface IProduct {
	id: number;
	brandName: string;
	detailName: string;
	price: number;
}

export interface ProductState {
	products: IProduct[];
	minPrice: number;
	maxPrice: number;
	sortBy: string;
	currentPage: number;
	totalPages: number;
}
export type ProductActionType =
	| { type: 'SET_MIN_PRICE'; payload: number }
	| { type: 'SET_MAX_PRICE'; payload: number }
	| { type: 'SET_SORT_BY'; payload: string }
	| { type: 'SET_CURRENT_PAGE'; payload: number }
	| { type: 'SET_TOTAL_PAGES'; payload: number }
	| { type: 'SET_PRODUCTS'; payload: IProduct[] };

export interface IProductContext {
	state: ProductState;
	dispatch: Dispatch<ProductActionType>;
}

export type ChildrenType = {
	children: JSX.Element | undefined;
};

export type ProductDataType = Omit<ProductState, 'sortBy' | 'currentPage'>;

export interface IProductCard {
	product: IProduct;
}

export interface IProductFilter {
	onFilterChange: (min: number, max: number) => void;
}

export interface IProductSort {
	sortBy: string;
	onSortChange: (value: string) => void;
}

export interface IPagination {
	currentPage: number;
	pageCount: number;
	onPageChange: (pageNumber: number) => void;
}

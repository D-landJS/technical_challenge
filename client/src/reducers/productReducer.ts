import {
	ProductState,
	ProductActionType,
} from '../interfaces/GlobalInterfaces';

const productReducer = (
	state: ProductState,
	action: ProductActionType
): ProductState => {
	switch (action.type) {
		case 'SET_PRODUCTS':
			return { ...state, products: action.payload };
		case 'SET_MIN_PRICE':
			return { ...state, minPrice: action.payload };
		case 'SET_MAX_PRICE':
			return { ...state, maxPrice: action.payload };
		case 'SET_SORT_BY':
			return { ...state, sortBy: action.payload };
		case 'SET_CURRENT_PAGE':
			return { ...state, currentPage: action.payload };
		case 'SET_TOTAL_PAGES':
			return { ...state, totalPages: action.payload };
		default:
			return state;
	}
};

export default productReducer;

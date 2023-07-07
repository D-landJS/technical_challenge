import React, { useContext, useEffect, useState } from 'react';
import { ProductContext } from '../../../context/productContext';
import ProductCard from '../../molecules/ProductCard/ProductCard';
import './ProductList.css';
import ProductFilter from '../../molecules/ProductFilter/ProductFilter';
import ProductSort from '../../molecules/ProductSort/ProductSort';
import Pagination from '../../molecules/Pagination/Pagination';
import {
	pageChange,
	filterChange,
	sortChange,
} from '../../../utils/productUtils';
import { getAllProducts } from '../../../services/productServices';
import { IProduct } from '../../../interfaces/GlobalInterfaces';

const ProductList: React.FC = () => {
	const { state, dispatch } = useContext(ProductContext);
	const { products, sortBy, totalPages, currentPage, minPrice, maxPrice } =
		state;
	const [rangePrice, setRangePrice] = useState({
		minPriceVal: 0,
		maxPriceVal: 0,
	});
	const productsPerPage = 10;

	useEffect(() => {
		const fetchData = async () => {
			try {
				const { products, totalPages, minPrice, maxPrice } =
					await getAllProducts();

				dispatch({ type: 'SET_PRODUCTS', payload: products });
				dispatch({ type: 'SET_TOTAL_PAGES', payload: totalPages });

				setRangePrice({ minPriceVal: minPrice, maxPriceVal: maxPrice });
			} catch (error) {
				console.error(error);
			}
		};

		fetchData();
	}, [dispatch]);

	const handleSortChange = async (order: string) => {
		await sortChange(
			order,
			currentPage,
			productsPerPage,
			minPrice,
			maxPrice,
			products,
			dispatch
		);
	};

	const handleFilterChange = async (min: number, max: number) => {
		await filterChange(
			min,
			max,
			rangePrice,
			sortBy,
			currentPage,
			productsPerPage,
			dispatch
		);
	};

	const handlePageChange = async (pageNumber: number) => {
		await pageChange(
			pageNumber,
			minPrice,
			maxPrice,
			productsPerPage,
			sortBy,
			dispatch
		);
	};

	return (
		<div className="product-list">
			<div className="product-list__filters">
				<ProductFilter onFilterChange={handleFilterChange} />
			</div>
			<div className="product-list__content">
				<div className="product-list__sort">
					<ProductSort sortBy={sortBy} onSortChange={handleSortChange} />
				</div>
				{products.length > 0 ? (
					<div className="product-list__cards">
						{products.map((product: IProduct) => (
							<ProductCard key={product.id} product={product} />
						))}
					</div>
				) : (
					<p>No hay productos disponibles.</p>
				)}
				<div className="product-list__pagination">
					<Pagination
						currentPage={currentPage}
						pageCount={totalPages}
						onPageChange={handlePageChange}
					/>
				</div>
			</div>
		</div>
	);
};

export default ProductList;

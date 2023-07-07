import React from 'react';
import './Pagination.css';
import { IPagination } from '../../../interfaces/GlobalInterfaces';

const Pagination: React.FC<IPagination> = ({
	currentPage,
	pageCount,
	onPageChange,
}) => {
	const handlePageChange = (pageNumber: number) => {
		if (pageNumber !== currentPage) {
			onPageChange(pageNumber);
		}
	};

	const isFirstPage = currentPage === 1;
	const isLastPage = currentPage === pageCount;

	const previousPage = () => {
		if (!isFirstPage) {
			handlePageChange(currentPage - 1);
		}
	};

	const nextPage = () => {
		if (!isLastPage) {
			handlePageChange(currentPage + 1);
		}
	};

	return (
		<ul className="pagination">
			<li
				className={`pagination__item${
					isFirstPage ? ' pagination__item--disabled' : ''
				}`}
				onClick={previousPage}
			>
				<div className="pagination__arrow">&lt;</div>
			</li>
			{[...Array(pageCount)].map((_, index) => {
				const pageNumber = index + 1;
				const isSelected = pageNumber === currentPage;
				const circleStyle = {
					backgroundColor: isSelected ? '#7300e0' : '',
					color: isSelected ? '#fff' : '#757575',
				};

				return (
					<li
						key={pageNumber}
						className={`pagination__item${
							isSelected ? ' pagination__item--selected' : ''
						}`}
						onClick={() => handlePageChange(pageNumber)}
					>
						<div className="pagination__circle" style={circleStyle}>
							<span>{pageNumber}</span>
						</div>
					</li>
				);
			})}
			<li
				className={`pagination__item${
					isLastPage ? ' pagination__item--disabled' : ''
				}`}
				onClick={nextPage}
			>
				<div className="pagination__arrow">&gt;</div>
			</li>
		</ul>
	);
};

export default Pagination;
